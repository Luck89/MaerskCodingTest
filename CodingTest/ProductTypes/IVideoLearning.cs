using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductTypes
{
    public interface IVideoLearning : IProduct
    {
        Task AddFreeFirstAidVideo(VideoTypes vType);
    }

    public enum VideoTypes
    {
        [Description("Learning to Ski")]
        LearningToSky = 1
    }
}
