using System.Diagnostics;
using Aspire.Hosting;

namespace HolisticWare.Tools.Aspire.Hosting.Clients.MatlabOctave;

public static partial class 
                                        IDistributedApplicationBuilderExtensions
{
    public static
        IResourceBuilder<ExecutableResource>?
                                        AddScriptMatlabOctave
                                        (
                                            this IDistributedApplicationBuilder? builder,
                                            string name,
                                            string executable,
                                            string directory,
                                            string[] args,
                                            string settings = "settings.m"
                                        )
    {
        IResourceBuilder<ExecutableResource>? resource_builder = builder?.AddExecutable
                                                                                (
                                                                                    name,
                                                                                    executable,
                                                                                    directory,
                                                                                    args
                                                                                );
        
        return resource_builder;
    }
}
