﻿using Dopamine.Data.Contracts.Entities;
using Dopamine.Data.Metadata;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dopamine.Services.Contracts.Metadata
{
    public interface IMetadataService
    {
        bool IsUpdatingDatabaseMetadata { get; }
        Task UpdateTrackRatingAsync(string path, int rating);
        Task UpdateTrackLoveAsync(string path, bool love);
        Task UpdateTracksAsync(List<FileMetadata> fileMetadatas, bool updateAlbumArtwork);
        Task UpdateAlbumAsync(Album album, MetadataArtworkValue artwork, bool updateFileArtwork);
        FileMetadata GetFileMetadata(string path);
        Task<FileMetadata> GetFileMetadataAsync(string path);
        Task<byte[]> GetArtworkAsync(string path);
        Task SafeUpdateFileMetadataAsync();
        event Action<MetadataChangedEventArgs> MetadataChanged;
        event Action<RatingChangedEventArgs> RatingChanged;
        event Action<LoveChangedEventArgs> LoveChanged;
    }
}