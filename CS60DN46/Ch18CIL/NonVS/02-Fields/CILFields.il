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
	.method public hidebysig specialname instance string get_TheString() cil managed
	{
      ldstr "CIL string"
      ret
	}
	// to update
	.method public hidebysig specialname instance void set_TheString(string 'value') vil managed {}
	.property instance string TheString()
	{
	  .get instance string MyNamespace.MyBaseClass::get_TheString()
	  .set instance void MyNamespace.MyBaseClass::set_TheString(string)
	}
  }
  .class public MyDerivedClass
    extends MyNamespace.MyBaseClass
	implements MyNamespace.IMyInterface
	{
	  .method private void Start()
      {
        //List<int> myInts = new List<int>();
        //newobj instance void class [mscorlib]System.Collections.Generic.List`1<int32>::.ctor()
        //Dictionary<string,int>
        newobj instance void class [mscorlib]System.Collections.Generic.Dictionary`2<string,int32>::.ctor()
	    //ret
	  }
	}
	
  .class public interface IMyOtherInterface implements MyNamespace.IMyInterface{}

  .class public sealed value MyStruct{}
  
  .class public sealed enum MyEnum
  {
    .field public static literal valuetype
	MyNamespace.MyEnum A = int32(0)
    .field public static literal valuetype
	MyNamespace.MyEnum B = int32(1)
    .field public static literal valuetype
	MyNamespace.MyEnum C = int32(2)
  }
}
