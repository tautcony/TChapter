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

using System.Collections.Generic;

namespace TChapter.Chapters
{
    public class SingleChapterData : MultiChapterData
    {
        public ChapterInfo Data
        {
            get => Count == 0 ? null : this[0];
            set
            {
                if (Count == 0) Add(value);
                else this[0] = value;
            }
        }

        public List<Chapter> Chapters => Data.Chapters;

        public SingleChapterData(ChapterTypeEnum chapterType) : base(chapterType)
        {
            Add(new ChapterInfo());
        }

        public void Save(ChapterTypeEnum chapterType, string savePath, bool removeName = false, string extraData = "")
        {
            Save(chapterType, savePath, 0, removeName, extraData);
        }
    }
}
