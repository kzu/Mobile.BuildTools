﻿using System.ComponentModel;
using Newtonsoft.Json;

namespace Mobile.BuildTools.Models.AppIcons
{
    public class BaseImageConfiguration : IImageResource
    {
        [DefaultValue(false)]
        [Description("Will ignore this image asset. This may be used to ignore an image for a specific platform or in general if using the image as a watermark for other images.")]
        [JsonProperty("ignore", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Ignore { get; set; }

        [Description("The name of the output image.")]
        [JsonProperty("name", Required = Required.AllowNull)]
        public string Name { get; set; }

        [DefaultValue(1.0)]
        [Description("The scale factor to scale the largest output image based on the size of the input image.")]
        [JsonProperty("scale", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double Scale { get; set; }

        [Description("A color that should be used to apply as a background for a transparent source image. This is particularly useful for app icons on iOS. By default the AppIcon on iOS will get a White background if the source is transparent and no value is specified here. This can be a hex value or name of a standard color.")]
        [JsonProperty("backgroundColor", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string BackgroundColor { get; set; }

        [Description("A specific override for the width of the largest output image.")]
        [JsonProperty("width", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Width { get; set; }

        [Description("A specific override for the height of the largest output image.")]
        [JsonProperty("height", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? Height { get; set; }

        [Description("The padding factor will resize the canvas size by the specified factor. For example a facor of 1.5 will increase the overall size of the canvas. This will then be resized back to the original source image size and scaled appropriately. This is useful for Round Icons on Android.")]
        [JsonProperty("padFactor", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? PaddingFactor { get; set; }

        [Description("This will set the background color for the padded area to the specified color. This can be a hex value or name of standard colors.")]
        [JsonProperty("padColor", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PaddingColor { get; set; }

        [Description("Specifies a configuration for adding a watermark or banner on a specified image.")]
        [JsonProperty("watermark", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public WatermarkConfiguration Watermark { get; set; }

        [Description("Specifies the output resource type for the image. This typically should be used within a platform specific configuration.")]
        [JsonProperty("resourceType", Required = Required.AllowNull, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PlatformResourceType ResourceType { get; set; }

        [JsonIgnore]
        public string SourceFile { get; set; }
    }
}
