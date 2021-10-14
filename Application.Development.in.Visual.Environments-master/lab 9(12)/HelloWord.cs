using System;

using System.Runtime.InteropServices;



namespace DemoCSharpActiveX

{

    /// <summary>

    /// Demo HelloWorld class

    /// </summary>

    [ProgId("DemoCSharpActiveX.HelloWorld")]

    [ClassInterface(ClassInterfaceType.AutoDual)]

    [Guid("415D09B9-3C9F-43F4-BB5C-C056263EF270")]

    [ComVisible(true)]

    public class HelloWord

    {

        [ComVisible(true)]

        public String SayHello()

        {

            return "Hello World!";

        }

    }

}