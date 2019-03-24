﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cajuine.AzureStorageAccount;
using Cajuine.DomainModel.Entities;
using Cajuine.DomainModel.Interfaces.Repositories;

namespace Cajuine.DataAccess.Repositories
{
    public class PhotoAzureBlobRepository : IPhotoRepository
    {
        public string Create(Photo photo)
        {
            var blobService = new BlobService();

            return blobService.UploadFile(photo.ContainerName,
                photo.FileName, photo.BinaryContent,
                photo.ContentType);
        }

        public async Task<string> CreateAsync(Photo photo)
        {
            var blobService = new BlobService();

            return await blobService.UploadFileAsync(photo.ContainerName,
                photo.FileName, photo.BinaryContent,
                photo.ContentType);
        }
    }
}
