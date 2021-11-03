namespace BuilderPattern
{
    /// <summary>
    /// 戴尔电脑组装商
    /// </summary>
    public class DellBuilder : Builder
    {
        readonly Computer _dell = new Computer() { Band = "戴尔" };

        protected override void BuildMainFramePart()
        {
            _dell.AssemblePart("主机");
        }

        protected override void BuildScreenPart()
        {
            _dell.AssemblePart("显示器");
        }

        protected override void BuildInputPart()
        {
            _dell.AssemblePart("键鼠");
        }

        public override Computer BuildComputer()
        {
            BuildInputPart();
            BuildMainFramePart();
            BuildScreenPart();
            return _dell;
        }
    }
}