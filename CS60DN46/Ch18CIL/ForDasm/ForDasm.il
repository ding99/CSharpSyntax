
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly ForDasm
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 46 6F 72 44 61 73 6D 00 00 )             // ...ForDasm..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 07 48 50 20 49 6E 63 2E 00 00 )             // ...HP Inc...
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 46 6F 72 44 61 73 6D 00 00 )             // ...ForDasm..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 19 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  48 50 20 49 6E 63 2E 20 32 30 32 30 00 00 )       // HP Inc. 2020..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 37 37 37 62 37 36 66 65 2D 33 37 32 62   // ..$777b76fe-372b
                                                                                                  2D 34 35 31 65 2D 61 66 30 66 2D 63 32 34 65 33   // -451e-af0f-c24e3
                                                                                                  36 66 36 39 33 61 31 00 00 )                      // 6f693a1..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module ForDasm.exe
// MVID: {66C70FCB-2B48-418A-AF44-79580CE00D73}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x09230000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit ForDasm.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint
    // Code size       100 (0x64)
    .maxstack  4
    .locals init ([0] class ForDasm.Person jason)
    IL_0000:  nop
    IL_0001:  ldstr      "== Reference for DeAsm"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  newobj     instance void ForDasm.Person::.ctor()
    IL_0011:  stloc.0
    IL_0012:  ldloc.0
    IL_0013:  ldstr      "Jason"
    IL_0018:  callvirt   instance void ForDasm.Person::set_Name(string)
    IL_001d:  nop
    IL_001e:  ldloc.0
    IL_001f:  ldc.i4.s   25
    IL_0021:  callvirt   instance void ForDasm.Person::set_Age(int32)
    IL_0026:  nop
    IL_0027:  ldloc.0
    IL_0028:  ldc.r8     160.69999999999999
    IL_0031:  callvirt   instance void ForDasm.Person::set_Weight(float64)
    IL_0036:  nop
    IL_0037:  ldstr      "Name:{0}, Age:{1}, Weight:{2}"
    IL_003c:  ldloc.0
    IL_003d:  callvirt   instance string ForDasm.Person::get_Name()
    IL_0042:  ldloc.0
    IL_0043:  callvirt   instance int32 ForDasm.Person::get_Age()
    IL_0048:  box        [mscorlib]System.Int32
    IL_004d:  ldloc.0
    IL_004e:  callvirt   instance float64 ForDasm.Person::get_Weight()
    IL_0053:  box        [mscorlib]System.Double
    IL_0058:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object,
                                                                object)
    IL_005d:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0062:  nop
    IL_0063:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class ForDasm.Program

.class private auto ansi beforefieldinit ForDasm.Person
       extends [mscorlib]System.Object
{
  .field private string '<Name>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private int32 '<Age>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private float64 '<Weight>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .method public hidebysig specialname instance string 
          get_Name() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string ForDasm.Person::'<Name>k__BackingField'
    IL_0006:  ret
  } // end of method Person::get_Name

  .method public hidebysig specialname instance void 
          set_Name(string 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string ForDasm.Person::'<Name>k__BackingField'
    IL_0007:  ret
  } // end of method Person::set_Name

  .method public hidebysig specialname instance int32 
          get_Age() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      int32 ForDasm.Person::'<Age>k__BackingField'
    IL_0006:  ret
  } // end of method Person::get_Age

  .method public hidebysig specialname instance void 
          set_Age(int32 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      int32 ForDasm.Person::'<Age>k__BackingField'
    IL_0007:  ret
  } // end of method Person::set_Age

  .method public hidebysig specialname instance float64 
          get_Weight() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      float64 ForDasm.Person::'<Weight>k__BackingField'
    IL_0006:  ret
  } // end of method Person::get_Weight

  .method public hidebysig specialname instance void 
          set_Weight(float64 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      float64 ForDasm.Person::'<Weight>k__BackingField'
    IL_0007:  ret
  } // end of method Person::set_Weight

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Person::.ctor

  .property instance string Name()
  {
    .get instance string ForDasm.Person::get_Name()
    .set instance void ForDasm.Person::set_Name(string)
  } // end of property Person::Name
  .property instance int32 Age()
  {
    .get instance int32 ForDasm.Person::get_Age()
    .set instance void ForDasm.Person::set_Age(int32)
  } // end of property Person::Age
  .property instance float64 Weight()
  {
    .get instance float64 ForDasm.Person::get_Weight()
    .set instance void ForDasm.Person::set_Weight(float64)
  } // end of property Person::Weight
} // end of class ForDasm.Person


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file D:\ProG\CSharpSyntax\CS60DN46\Ch18CIL\ForDasm\ForDasm.res
