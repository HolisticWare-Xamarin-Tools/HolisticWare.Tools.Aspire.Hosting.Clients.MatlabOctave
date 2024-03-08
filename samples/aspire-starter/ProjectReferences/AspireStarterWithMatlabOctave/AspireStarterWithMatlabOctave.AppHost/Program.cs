using HolisticWare.Tools.Aspire.Hosting.Clients.MatlabOctave;
using HolisticWare.Tools.Aspire.Hosting.Clients.Python;

var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.AspireStarterWithMatlabOctave_ApiService>("apiservice");

builder.AddProject<Projects.AspireStarterWithMatlabOctave_Web>("webfrontend")
    .WithReference(apiService);

builder.AddScriptMatlabOctave
                (
                    "clients-matlab-octave-machine-learning-anomaly-detection",
                    "octave",
                    "../Clients/MatLabOctave/machine-learning-octave-master/anomaly-detection/",
                    new string[] { "demo.m"}
                )
                .WithReference(apiService)
                .GenerateSettings()
                ;

builder.AddScriptMatlabOctave
                (
                    "clients-matlab-octave-machine-learning-k-means",
                    "octave",
                    "../Clients/MatLabOctave/machine-learning-octave-master/k-means",
                    new string[] { "demo.m"}
                )
                .WithReference(apiService)
                .GenerateSettings()
                ;

builder.Build().Run();
