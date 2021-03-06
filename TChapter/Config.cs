﻿// ****************************************************************************
//
// Copyright (C) 2017 TautCony (TautCony@vcb-s.com)
//
// This program is free software; you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation; either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
//
// ****************************************************************************

using System.Text.RegularExpressions;

namespace TChapter
{
    public static class Config
    {
        public const string DEFAULT_CHAPTER_NAME = "Chapter";

        public static Regex TIME_FORMAT = new Regex(@"(?<Hour>\d+)\s*:\s*(?<Minute>\d+)\s*:\s*(?<Second>\d+)\s*[\.,]\s*(?<Millisecond>\d{3})", RegexOptions.Compiled);

        public static readonly decimal[] FRAME_RATE = { 0M, 24000M / 1001, 24M, 25M, 30000M / 1001, 0M, 50M, 60000M / 1001 };
    }
}
