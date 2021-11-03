namespace BuilderPattern
{
    /// <summary>
    /// 惠普电脑组装商
    /// </summary>
    public class HpBuilder : Builder
    {
        readonly Computer _hp = new Computer() { Band = "惠普" };

        protected override void BuildMainFramePart()
        {
            _hp.AssemblePart("主机");
        }

        protected override void BuildScreenPart()
        {
            _hp.AssemblePart("显示器");
        }

        protected override void BuildInputPart()
        {
            _hp.AssemblePart("键鼠");
        }

        /// <summary>
        /// 决定具体的组装步骤
        /// </summary>
        /// <returns></returns>
        public override Computer BuildComputer()
        {
            BuildMainFramePart();
            BuildScreenPart();
            BuildInputPart();
            return _hp;
        }
    }
}