// Copyright (c) .NET Foundation and Contributors (https://dotnetfoundation.org/ & https://stride3d.net) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.

using System.Collections.Generic;
using System.ComponentModel;

using Stride.Core;
using Stride.Rendering;

namespace Stride.Rendering.ProceduralModels
{
    /// <summary>
    /// Interface to create a procedural model.
    /// </summary>
    public interface IProceduralModel
    {
        /// <summary>
        /// Creates a procedural model.
        /// </summary>
        /// <param name="services">The services registry.</param>
        /// <param name="model">A model instance to fill with procedural content.</param>
        void Generate(IServiceRegistry services, Model model);

        void SetMaterial(string name, Material material);

        /// <summary>
        /// Gets the collection of material instances used by this <see cref="IProceduralModel"/>/
        /// </summary>
        [Display(Browsable = false)]
        IEnumerable<KeyValuePair<string, MaterialInstance>> MaterialInstances { get; }
    }
}
