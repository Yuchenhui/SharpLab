using Autofac;
using JetBrains.Annotations;
using SharpLab.Server.Decompilation;

namespace SharpLab.Server.AspNetCore.Decompilation {
    [UsedImplicitly]
    public class DecompilationModule : Module {
        protected override void Load(ContainerBuilder builder) {
            builder.RegisterType<JitAsmDecompiler>()
                   .As<IDecompiler>()
                   .SingleInstance();
        }
    }
}
