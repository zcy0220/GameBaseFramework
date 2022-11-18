/**
 * 网关接口
 */

namespace GameBaseFramework.Networks
{
    public interface IGateway
    {
        /// <summary>
        /// Clean
        /// </summary>
        public void Close();
        /// <summary>
        /// Dump
        /// </summary>
        public void Dump();
        /// <summary>
        /// Tick
        /// </summary>
        public void Tick();
    }
}
