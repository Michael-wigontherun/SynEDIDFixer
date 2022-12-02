using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;

namespace SynEDIDFixer
{
    public partial class Program
    {
        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .Run(args);
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            SeperateLoops(state);

            //This was test code, for a bug
            //FormKey boundBow = FormKey.TryFactory("0211ED:Skyrim.esm")!.Value;

            //foreach (var context in state.LoadOrder.PriorityOrder.WinningOverrideContexts<ISkyrimMod, ISkyrimModGetter, IMajorRecord, IMajorRecordGetter>(state.LinkCache).Catch(exception =>
            //{
            //    Console.WriteLine(exception.Message);
            //}))
            //{
            //    //var contextCopy = context.GetOrAddAsOverride(state.PatchMod);
            //    if (context.Record.FormKey.Equals(boundBow))
            //    {
            //        Console.WriteLine("FormKey match");
            //    }
            //    if (context.Record.FormKey.IDString().Contains("211ED") && context.Record.FormKey.ModKey.Equals(boundBow.ModKey))
            //    {
            //        Console.WriteLine("FormKey match as string");
            //    }
            //}
        }
    }
}
