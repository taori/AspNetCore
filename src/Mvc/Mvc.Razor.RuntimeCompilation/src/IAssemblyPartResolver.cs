﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation
{
    /// <summary>
    /// When implementing this interface you should make sure to recursively handle the dependencies which result from referencing a given part
    /// </summary>
    internal interface IAssemblyPartResolver
    {
        /// <summary>
        /// When implementing this interface you should make sure to recursively handle the dependencies which result from referencing a given part
        /// </summary>
        /// <param name="assemblyPart"></param>
        /// <returns>All references which are dependencies of this application part.</returns>
        IEnumerable<string> GetReferencePaths(AssemblyPart assemblyPart);
    }
}