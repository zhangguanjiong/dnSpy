﻿/*
    Copyright (C) 2014-2015 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.IO;
using System.Threading;

namespace dnSpy.Contracts.Files.TreeView.Resources {
	/// <summary>
	/// Raw resource data
	/// </summary>
	public sealed class ResourceData {
		/// <summary>
		/// Name of resource
		/// </summary>
		public string Name {
			get { return name; }
		}
		readonly string name;

		/// <summary>
		/// Gets the stream
		/// </summary>
		/// <param name="token">Cancellation token</param>
		/// <returns></returns>
		public Stream GetStream(CancellationToken token) {
			return getStream(token);
		}
		readonly Func<CancellationToken, Stream> getStream;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="name">Name</param>
		/// <param name="getStream">Returns the stream</param>
		public ResourceData(string name, Func<CancellationToken, Stream> getStream) {
			this.name = name;
			this.getStream = getStream;
		}
	}
}