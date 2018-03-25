﻿using Bitbucket.Net.Models.Projects;

namespace Bitbucket.Net.Common.Converters
{
    public class FileTypesConverter : JsonEnumConverter<FileTypes>
    {
        protected override string ConvertToString(FileTypes value)
        {
            return BitbucketHelpers.FileTypeToString(value);
        }

        protected override FileTypes ConvertFromString(string s)
        {
            return BitbucketHelpers.StringToFileType(s);
        }
    }
}
