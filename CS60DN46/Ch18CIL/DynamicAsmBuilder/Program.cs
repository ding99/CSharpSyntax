﻿using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Threading;

namespace DynamicAsmBuilder {
	class Program {
		static void Main() {
			Console.WriteLine("***** Dynamic Assembly Builder *****");
			AppDomain domain = Thread.GetDomain();
			CreateMyAsm(domain);
			Console.ResetColor();
		}

		private static void CreateMyAsm(AppDomain curAppDomain) {
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("=> Create an assembly");

			AssemblyName assemblyName = new AssemblyName {
				Name = "MyAssembly", Version = new Version("1.0.0.0")
			};
			AssemblyBuilder assembly = curAppDomain.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Save);
			ModuleBuilder module = assembly.DefineDynamicModule("MyAssembly", "MyAssembly.dll");
			TypeBuilder helloWorldClass = module.DefineType("MyAssembly.HelloWorld", TypeAttributes.Public);
			FieldBuilder msgField = helloWorldClass.DefineField("theMessage", Type.GetType("System.String"), FieldAttributes.Private);

			Type[] constructorArgs = { typeof(string) };
			ConstructorBuilder constructor = helloWorldClass.DefineConstructor(MethodAttributes.Public, CallingConventions.Standard, constructorArgs);
			
			ILGenerator constructorIL = constructor.GetILGenerator();
			constructorIL.Emit(OpCodes.Ldarg_0);
			Type objectClass = typeof(object);
			ConstructorInfo superConstructor = objectClass.GetConstructor(new Type[0]);
			constructorIL.Emit(OpCodes.Call, superConstructor);
			constructorIL.Emit(OpCodes.Ldarg_0);
			constructorIL.Emit(OpCodes.Ldarg_1);
			constructorIL.Emit(OpCodes.Stfld, msgField);
			constructorIL.Emit(OpCodes.Ret);

			helloWorldClass.DefineDefaultConstructor(MethodAttributes.Public);

			MethodBuilder getMsgMethod = helloWorldClass.DefineMethod("GetMsg", MethodAttributes.Public, typeof(string), null);
			ILGenerator methodIL = getMsgMethod.GetILGenerator();
			methodIL.Emit(OpCodes.Ldarg_0);
			methodIL.Emit(OpCodes.Ldfld, msgField);
			methodIL.Emit(OpCodes.Ret);

			MethodBuilder sayHiMethod = helloWorldClass.DefineMethod("SayHello", MethodAttributes.Public, null, null);
			methodIL = sayHiMethod.GetILGenerator();
			methodIL.EmitWriteLine("Hello from the HelloWorld class!");
			methodIL.Emit(OpCodes.Ret);

			helloWorldClass.CreateType();
			assembly.Save("MyAssembly.dll");
		}
	}
}

/*
public class HelloWorld {
	private string theMessage;
	HelloWorld() {}
	HelloWorld(string s) { theMessage = s; }
	public string GetMsg() { return theMessage; }
	public void SayHello() { WriteLine("Hello from the HelloWorld class!"); }
}
*/
