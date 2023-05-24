﻿using GalleryApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace GalleryApp
{
    public interface IPhotoImporter
    {
        Task<ObservableCollection<Photo>> Get( int start, int count, Quality quality = Quality.Low);
        Task<ObservableCollection<Photo>> Get( List<string> filenames, Quality quality = Quality.Low);
    }

    public enum Quality
    {
        Low,
        High
    }
}
