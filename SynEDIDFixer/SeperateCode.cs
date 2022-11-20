using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins.Records;
using Mutagen.Bethesda.Plugins;
using System.Collections.Immutable;
using Mutagen.Bethesda.Plugins.Cache.Internals.Implementations;
using Noggog;
using CommandLine;
using Mutagen.Bethesda.Plugins.Cache;

namespace SynEDIDFixer
{
    public partial class Program
    {
        public static void SeperateLoops(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            //Spells
            foreach (var latestRec in state.LoadOrder.PriorityOrder.Spell().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Spells.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.WordOfPower().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.WordsOfPower.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Perks
            foreach (var latestRec in state.LoadOrder.PriorityOrder.Perk().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Perks.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Items
            foreach (var latestRec in state.LoadOrder.PriorityOrder.MiscItem().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.MiscItems.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Armor().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Armors.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Weapon().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Weapons.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Ingestible().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Ingestibles.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Ingredient().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Ingredients.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Ammunition().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Ammunitions.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.AlchemicalApparatus().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.AlchemicalApparatuses.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Book().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Books.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Scroll().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Scrolls.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.SoulGem().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.SoulGems.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Key().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Keys.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.LeveledItem().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.LeveledItems.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.LeveledNpc().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.LeveledNpcs.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.LeveledSpell().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.LeveledSpells.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Packages
            foreach (var latestRec in state.LoadOrder.PriorityOrder.Package().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Packages.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Outfits
            foreach (var latestRec in state.LoadOrder.PriorityOrder.Outfit().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Outfits.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Keywords
            foreach (var latestRec in state.LoadOrder.PriorityOrder.Keyword().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Keywords.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Factions
            foreach (var latestRec in state.LoadOrder.PriorityOrder.Faction().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Factions.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //FormLists
            foreach (var latestRec in state.LoadOrder.PriorityOrder.FormList().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.FormLists.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Furniture
            foreach (var latestRec in state.LoadOrder.PriorityOrder.Door().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Doors.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Furniture().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Furniture.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Flora().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Florae.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Static().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Statics.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.MoveableStatic().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.MoveableStatics.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.Tree().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.Trees.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            foreach (var latestRec in state.LoadOrder.PriorityOrder.AnimatedObject().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.AnimatedObjects.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }

            //Sound
            foreach (var latestRec in state.LoadOrder.PriorityOrder.SoundDescriptor().WinningOverrides())
            {
                if (state.LinkCache.TryResolve<IMajorRecordGetter>(latestRec.FormKey, out IMajorRecordGetter? orgRec, ResolveTarget.Origin))
                {
                    if (latestRec.EditorID != null)
                    {
                        if (orgRec.EditorID != null)
                        {
                            if (!latestRec.EditorID.Equals(orgRec.EditorID))
                            {
                                var lRecCopy = latestRec.DeepCopy();
                                lRecCopy.EditorID = orgRec.EditorID;

                                state.PatchMod.SoundDescriptors.GetOrAddAsOverride(lRecCopy);
                            }
                        }
                    }
                }
            }
        }
    }
}
