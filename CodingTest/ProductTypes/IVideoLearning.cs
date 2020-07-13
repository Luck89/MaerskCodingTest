using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest.ProductTypes
{
    public interface IVideoLearning : IProduct
    {
        void AddFreeFirstAidVideo();
    }

    public enum VideoTypes
    {
        [Description("Learning to Ski")]
        LearningToSki = 1,
        Others = 2
    }
}
