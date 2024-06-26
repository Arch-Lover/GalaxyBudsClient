using GalaxyBudsClient.Generated.I18N;
using GalaxyBudsClient.Generated.Model.Attributes;
using GalaxyBudsClient.Model.Attributes;

namespace GalaxyBudsClient.Message.Decoder;

[MessageDecoder(MsgIds.CHECK_THE_FIT_OF_EARBUDS_RESULT)]
public class FitTestDecoder(SppMessage msg) : BaseMessageDecoder(msg)
{
    public Result Left { get; } = (Result)msg.Payload[0];
    public Result Right { get; } = (Result)msg.Payload[1];

    [CompiledEnum]
    public enum Result
    {
        [LocalizableDescription(Keys.GftBad)]
        Bad = 0,
        [LocalizableDescription(Keys.GftGood)]
        Good = 1,
        [LocalizableDescription(Keys.GftFail)]
        TestFailed = 2
    }
}