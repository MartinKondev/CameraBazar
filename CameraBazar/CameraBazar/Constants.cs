using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CameraBazar
{
    public static class Constants
    {
        public const string UserNameRegexPattern = @"[a-zA-Z]+";

        public const string UserPhoneNumberRegexPattern = @"\+\d{10,12}";

        public const string FloatingPointNumberAfterDecimalPoint = @"\d+\.\d{0,2}";

        public const string CameraModelRegex = @"[\dA-Z-]+";

        public const string ImageUrlPattern = @"^https?:\/\/.+";
    }
}
