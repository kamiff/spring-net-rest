﻿#region License

/*
 * Copyright 2002-2012 the original author or authors.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#endregion

using System;

namespace Spring.Json
{
    /// <summary>
    /// An interface to serialize object of arbitrary type into JSON.
    /// </summary>
    /// <author>Bruno Baia</author>
    public interface IJsonSerializer
    {
        /// <summary>
        /// Serialize the specified <paramref name="obj"/> to a <see cref="JsonValue"/>.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <param name="mapper">The <see cref="JsonMapper"/> to use.</param>
        /// <returns>A <see cref="JsonValue"/> object created from the passed objects.</returns>
        JsonValue Serialize(object obj, JsonMapper mapper);
    }
}
