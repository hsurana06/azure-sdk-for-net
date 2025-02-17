// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Properties of a labeling job for text data. </summary>
    public partial class LabelingJobTextProperties : LabelingJobMediaProperties
    {
        /// <summary> Initializes a new instance of LabelingJobTextProperties. </summary>
        public LabelingJobTextProperties()
        {
            MediaType = MediaType.Text;
        }

        /// <summary> Initializes a new instance of LabelingJobTextProperties. </summary>
        /// <param name="mediaType"> [Required] Media type of the job. </param>
        /// <param name="annotationType"> Annotation type of text labeling job. </param>
        internal LabelingJobTextProperties(MediaType mediaType, TextAnnotationType? annotationType) : base(mediaType)
        {
            AnnotationType = annotationType;
            MediaType = mediaType;
        }

        /// <summary> Annotation type of text labeling job. </summary>
        public TextAnnotationType? AnnotationType { get; set; }
    }
}
