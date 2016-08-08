using PostSharp.Aspects;
using System;

namespace KV.Postsharp.Profile
{
    [Serializable]
    public class UpdateProfilerLog : OnMethodBoundaryAspect
    {
        public override void OnExit(MethodExecutionArgs args)
        {
            Logger.InsertLog(args, ActionLogEnum.Update);
        }
    }
}