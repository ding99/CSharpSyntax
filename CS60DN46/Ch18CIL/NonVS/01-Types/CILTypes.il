.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 90)
  .ver 4:0:0:0
}
.assembly CILTypes
{
  .ver 1:0:0:0
}
.module CILTypes.dll
.namespace MyNamespace
{
  .class public interface IMyInterface {}
  .class public MyBaseClass{}
  .class public MyDerivedClass
    extends MyNamespace.MyBaseClass
	implements MyNamespace.IMyInterface{}
	
  .class public interface IMyOtherInterface implements MyNamespace.IMyInterface{}

  .class public sealed value MyStruct{}
  .class public sealed MyStruct2 extends [mscorlib]System.ValueType{}  
  
  .class public sealed enum MyEnum{}
  .class public sealed MyEnum2 extends [mscorlib]System.Enum{}
}
