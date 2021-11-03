namespace BuilderPattern
{
    /// <summary>
    /// 建造者（模拟装机过程）,也可通过接口实现
    /// Director不关心具体组装的细节，所以将具体的组装细节方法标记为protected
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 组装主机
        /// </summary>
        protected abstract void BuildMainFramePart();

        /// <summary>
        /// 组装显示器
        /// </summary>
        protected abstract void BuildScreenPart();

        /// <summary>
        /// 组装输入设备（键鼠）
        /// </summary>
        protected abstract void BuildInputPart();

        /// <summary>
        /// 获取组装电脑
        /// 由具体的组装类决定组装顺序
        /// </summary>
        /// <returns></returns>
        public abstract Computer BuildComputer();
    }
}