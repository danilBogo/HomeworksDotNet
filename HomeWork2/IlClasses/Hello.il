.class public auto ansi beforefieldinit
  IlClasses.Hello
    extends [System.Runtime]System.Object
{

  .method public hidebysig static int32
    Test() cil managed
  {
    .maxstack 8

    // [5 33 - 5 36]
    IL_0000: ldc.i4       228 // 0x000000e4
    IL_0005: ret

  } // end of method Hello::Test

  .method public hidebysig specialname rtspecialname instance void
    .ctor() cil managed
  {
    .maxstack 8

    IL_0000: ldarg.0      // this
    IL_0001: call         instance void [System.Runtime]System.Object::.ctor()
    IL_0006: nop
    IL_0007: ret

  } // end of method Hello::.ctor
} // end of class ConsoleApp.Hello
