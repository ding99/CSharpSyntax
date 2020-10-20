.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 90)
  .ver 4:0:0:0
}
.assembly CILFields
{
  .ver 1:0:0:0
}
.module CILFields.dll
.namespace MyNamespace
{
  .class public interface IMyInterface {}
  .class public MyBaseClass
  {
    .field private string stringField = "hello!"
	.field private int32 intField = int32(42)
	//property TheString
	.field private string '<TheString>k__BackingField'
	.method public hidebysig specialname instance string get_TheString() cil managed
	{
	  .custom instance void [mscorlib]System.Runtime.CompilerServices.ComplilerGeneratedAttribute::.ctor() = (01 00 00 00)
	  ldarg.0
	  ldfld string MyNamespace.MyBaseClass::'<TheString>k__BackingField'
      ret
	}
	// to update
	.method public hidebysig specialname instance void set_TheString(string 'value') cil managed 
	{
	  .custom instance void [mscorlib]System.Runtime.CompilerServices.ComplilerGeneratedAttribute::.ctor() = (01 00 00 00)
	  ldarg.0
	  ldarg.1
	  stfld string MyNamespace.MyBaseClass::'<TheString>k__BackingField'
	  ret
	}
	.property instance string TheString()
	{
	  .get instance string MyNamespace.MyBaseClass::get_TheString()
	  .set instance void MyNamespace.MyBaseClass::set_TheString(string)
	}
	
	//public void MyMethod(int inInt, ref int refInt, ArrayList ar, out int outInt){ outInt = 0; }
	.method public hidebysig void MyMethod(int32 inInt, int32& refInt, class [mscorlib]System.Collections.ArrayList ar, [out] int32& outInt) cil managed{}
  }
  .class public MyDerivedClass
    extends MyNamespace.MyBaseClass
	implements MyNamespace.IMyInterface
	{
	  .method private hidebysig void Start() cil managed
      {
        //List<int> myInts = new List<int>();
        newobj instance void class [mscorlib]System.Collections.Generic.List`1<int32>::.ctor()
		pop
        //Dictionary<string,int>
        newobj instance void class [mscorlib]System.Collections.Generic.Dictionary`2<string,int32>::.ctor()
		pop
	    ret
	  }
	  
	  // Public static void MyLocalVariables()
	  // { string myStr = "CIL code is fun!"; int myInt = 33;
	  // object myObj = new object(); }
	  .method public hidebysig static void MyLocalVariables() cil managed
	  {
	    .maxstack 8
		.locals init ([0] string myStr, [1] int32 myInt, [2] object myObj)
		ldstr "CIL code is fun!"
		stloc.0
		ldc.i4 33
		stloc.1
		newobj instance void [mscorlib]System.Object::.ctor()
		stloc.2
		ret
	  }
	  
	  // public static int Add(int a, int b){ return a + b; }
	  .method public hidebysig static int32 Add(int32 a, int32 b) cil managed
	  {
	    .maxstack 2
		ldarg.0
		ldarg.1
		add
		ret
	  }
	}
	
  .class public interface IMyOtherInterface implements MyNamespace.IMyInterface{}

  //.class public sealed value MyStruct{}
  
//  .class public sealed enum MyEnum
//  {
//    .field public static literal valuetype
//	MyNamespace.MyEnum A = int32(0)
//    .field public static literal valuetype
//	MyNamespace.MyEnum B = int32(1)
//    .field public static literal valuetype
//	MyNamespace.MyEnum C = int32(2)
//  }
}
