using System;

namespace QualityTraining.Settings
{
    /*
     * How to unit test this class ?
     * 
     * Note: do not hesitate to modify/rewrite the code but
     * this class must call the ReadParamValue/WriteParamValue
     * methods though to accomplish the job.
    */

    public class GlobalSettings
    {
        public string GetParam(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }
            return AppConfiguration.Instance.ReadParamValue(name);
        }

        public string SetParam(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException();
            }
            return AppConfiguration.Instance.WriteParamValue(name);
        }
    }
}
