using PostSharp.Aspects;
using System;

namespace KV.Postsharp.Profile
{
    [Serializable]
    public class DeleteProfilerLog : OnMethodBoundaryAspect
    {
        public override void OnExit(MethodExecutionArgs args)
        {
            Logger.InsertLog(args, ActionLogEnum.Delete);
        }
    }
}