using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace CommandPattern.Practice2
{
    public abstract class Command
    {

        public abstract void Execute();

    }

    public class Print1Command : Command
    {
        public override void Execute()
        {
            Debug.Log("1");
        }
    }

    public class Print2Command : Command
    {
        public override void Execute()
        {
            Debug.Log("2");
        }
    }

    public class Print3Command : Command
    {
        public override void Execute()
        {
            Debug.Log("3");
        }
    }

    public class Print4Command : Command
    {
        public override void Execute()
        {
            Debug.Log("4");
        }
    }

    public class Print5Command : Command
    {
        public override void Execute()
        {
            Debug.Log("5");
        }
    }

    public class PrintSeparatorCommand : Command
    {
        public override void Execute()
        {
            Debug.Log("------------------------------------------------------------------------------------");
        }
    }

}
