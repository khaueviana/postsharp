using log4net;
using PostSharp.Aspects;
using System;
using System.Text;

namespace KV.Postsharp.Profile
{
    [Serializable]
    public class GenericProfiler : OnMethodBoundaryAspect
    {
        private ActionLogEnum action;

        public GenericProfiler(ActionLogEnum action)
        {
            this.action = action;
        }

        public override void OnExit(MethodExecutionArgs args)
        {
            StringBuilder strObjectAction = new StringBuilder();
            strObjectAction.Append("Action: ");
            strObjectAction.Append(action.ToString());
            strObjectAction.Append("- Path: ");
            strObjectAction.Append(args.Method.ReflectedType.UnderlyingSystemType.ToString());
            strObjectAction.Append("- Method Name: ");
            strObjectAction.Append(args.Method.ToString());
            strObjectAction.Append("- Arguments Values: ");
            strObjectAction.Append(string.Join(",", args.Arguments.ToArray()));

            LogManager.GetLogger("InformationLogger").Info(strObjectAction.ToString());
        }
    }
}
