using log4net;
using PostSharp.Aspects;
using System.Text;

namespace KV.Postsharp.Profile
{
    public class Logger
    {
        private static void LogInformation(string information)
        {            
            LogManager.GetLogger("InformationLogger").Info(information);
        }

        public static void InsertLog(MethodExecutionArgs args, ActionLogEnum action)
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

            LogInformation(strObjectAction.ToString());
        }
    }
}
