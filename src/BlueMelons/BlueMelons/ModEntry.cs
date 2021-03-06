﻿using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValley;

namespace BlueMelons
{
    public class ModEntry : Mod, IAssetLoader
    {
        /// <summary>The mod entry point, called after the mod is first loaded.</summary>
        /// <param name="helper">Provides simplified APIs for writing mods.</param>
        public override void Entry(IModHelper helper)
        {
            // Do nothing
        }

        /// <summary>Get whether this instance can load the initial version of the given asset.</summary>
        /// <param name="asset">Basic metadata about the asset being loaded.</param>
        public bool CanLoad<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("TileSheets/crops"))
            {
                return true;
            }

            if (asset.AssetNameEquals("Maps/springobjects"))
            {
                return true;
            }

            return false;
        }

        /// <summary>Load a matched asset.</summary>
        /// <param name="asset">Basic metadata about the asset being loaded.</param>
        public T Load<T>(IAssetInfo asset)
        {
            if (asset.AssetNameEquals("TileSheets/crops"))
            {
                return this.Helper.Content.Load<T>("assets/crops-new.png", ContentSource.ModFolder);
            }

            if (asset.AssetNameEquals("Maps/springobjects"))
            {
                return this.Helper.Content.Load<T>("assets/springobjects-new.png", ContentSource.ModFolder);
            }

            throw new InvalidOperationException($"Unexpected asset '{asset.AssetName}'.");
        }
    }
}
