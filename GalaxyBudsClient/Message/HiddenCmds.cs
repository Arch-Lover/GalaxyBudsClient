using System.Collections.Generic;

namespace GalaxyBudsClient.Message;

public static class HiddenCmds
{
    public static Dictionary<ushort, string> Commands { get; } = new()
    {
        {0x0002,"TWU_AT_CMD_ID_VER_HW_SET"},
        {0x0003,"TWU_AT_CMD_ID_VER_HW_GET"},
        {0x0004,"TWU_AT_CMD_ID_MODEL_NAME_GET"},
        {0x0005,"TWU_AT_CMD_ID_CHIP_NAME_GET"},
        {0x0006,"TWU_AT_CMD_ID_VER_SW_GET"},
        {0x0007,"TWU_AT_CMD_ID_TSP_FW_IC_VER_GET"},
        {0x0008,"TWU_AT_CMD_ID_TSP_FW_SW_VER_GET"},
        {0x0009,"TWU_AT_CMD_ID_TSP_SELF_TEST_ABS_VALUE_GET"},
        {0x000A,"TWU_AT_CMD_ID_TSP_DELTA_GET"},
        {0x000B,"TWU_AT_CMD_ID_SERIAL_NUMBER_SET"},
        {0x000C,"TWU_AT_CMD_ID_SERIAL_NUMBER_GET"},
        {0x000D,"TWU_AT_CMD_ID_ACC_ON"},
        {0x000E,"TWU_AT_CMD_ID_ACC_XYZ_READ"},
        {0x0012,"TWU_AT_CMD_ID_ACC_SELFTEST"},
        {0x0013,"TWU_AT_CMD_ID_ACC_OFF"},
        {0x001A,"TWU_AT_CMD_ID_GYRO_ON"},
        {0x001B,"TWU_AT_CMD_ID_GYRO_TEMP_READ"},
        {0x001C,"TWU_AT_CMD_ID_GYRO_SELFTEST"},
        {0x001D,"TWU_AT_CMD_ID_GYRO_OFF"},
        {0x001E,"TWU_AT_CMD_ID_PROXIMITY_1_ON"},
        {0x001F,"TWU_AT_CMD_ID_PROXIMITY_1_CHECK"},
        {0x0024,"TWU_AT_CMD_ID_PROXIMITY_1_ADC_READ"},
        {0x0025,"TWU_AT_CMD_ID_PROXIMITY_1_OFF"},
        {0x0026,"TWU_AT_CMD_ID_CAL_DATE_SET"},
        {0x0027,"TWU_AT_CMD_ID_CAL_DATE_GET"},
        {0x002E,"TWU_AT_CMD_ID_BT_ENABLE"},
        {0x0030,"TWU_AT_CMD_ID_BT_ADDR_LOCAL_SET"},
        {0x0031,"TWU_AT_CMD_ID_BT_ADDR_LOCAL_GET"},
        {0x0033,"TWU_AT_CMD_ID_ACC_VECTOR_SUM"},
        {0x0034,"TWU_AT_CMD_ID_LE_TX_TEST_CH0"},
        {0x0035,"TWU_AT_CMD_ID_LE_TX_TEST_CH19"},
        {0x0036,"TWU_AT_CMD_ID_LE_TX_TEST_CH39"},
        {0x0037,"TWU_AT_CMD_ID_LE_TX_TEST_PAYLOAD_0x0F_CH0"},
        {0x0038,"TWU_AT_CMD_ID_LE_TX_TEST_PAYLOAD_0x0F_CH19"},
        {0x0039,"TWU_AT_CMD_ID_LE_TX_TEST_PAYLOAD_0x0F_CH39"},
        {0x003A,"TWU_AT_CMD_ID_LE_TX_TEST_PAYLOAD_0xAA_CH0"},
        {0x003B,"TWU_AT_CMD_ID_LE_TX_TEST_PAYLOAD_0xAA_CH19"},
        {0x003C,"TWU_AT_CMD_ID_LE_TX_TEST_PAYLOAD_0xAA_CH39"},
        {0x003D,"TWU_AT_CMD_ID_LE_TX_TEST_CARRIER_CH0"},
        {0x003E,"TWU_AT_CMD_ID_LE_TX_TEST_CARRIER_CH19"},
        {0x003F,"TWU_AT_CMD_ID_LE_TX_TEST_CARRIER_CH39"},
        {0x0040,"TWU_AT_CMD_ID_LE_TX_TEST_BAND_EMISSION_CH0"},
        {0x0041,"TWU_AT_CMD_ID_LE_TX_TEST_BAND_EMISSION_CH19"},
        {0x0042,"TWU_AT_CMD_ID_LE_TX_TEST_BAND_EMISSION_CH37"},
        {0x0043,"TWU_AT_CMD_ID_LE_RX_TEST_CH0"},
        {0x0044,"TWU_AT_CMD_ID_LE_RX_TEST_CH19"},
        {0x0045,"TWU_AT_CMD_ID_LE_RX_TEST_CH37"},
        {0x0046,"TWU_AT_CMD_ID_LE_RX_TEST_END"},
        {0x0047,"TWU_AT_CMD_ID_BT_ADDR_LOCAL_SET"},
        {0x0048,"TWU_AT_CMD_ID_BT_ADDR_LOCAL_GET"},
        {0x004A,"TWU_AT_CMD_ID_SLEEP_MODE_SET"},
        {0x004C,"TWU_AT_CMD_ID_HEAD_INFO"},
        {0x004D,"TWU_AT_CMD_ID_THERMISTOR_TEMP_GET"},
        {0x004E,"FCBTTEST"},
        {0x004F,"TWU_AT_CMD_ID_OUT_BATT_VOLTAGE_GET"},
        {0x0050,"TWU_AT_CMD_ID_IN_BATT_VOLTAGE_GET"},
        {0x0055,"TWU_AT_CMD_ID_FACTORY_RESET"},
        {0x0056,"TWU_AT_CMD_ID_RF_TEST"},
        {0x0057,"SPKSTEST"},
        {0x0058,"TSPPTEST"},
        {0x005A,"SPKSTEST"},
        {0x005B,"TWU_AT_CMD_ID_POWER_OFF"},
        {0x005C,"TWU_AT_CMD_ID_SHIP_MODE_SET"},
        {0x005E,"TWU_AT_CMD_ID_BINARY_TYPE"},
        {0x0065,"TWU_AT_CMD_ID_EAR_DIRECTION_GET"},
        {0x0074,"TWU_AT_CMD_ID_PGM_LOG"},
        {0x0075,"TWU_AT_CMD_ID_POWER_OFF_TIMER_THREE_MIN"},
        {0x0077,"TWU_AT_CMD_ID_BATT_CHARGING_CURRENT_GET"},
        {0x0078,"TWU_AT_CMD_ID_HALL_IC_TEST"},
        {0x007C,"TWU_AT_CMD_ID_PLC_TEST_BT_CP"},
        {0x007D,"TWU_AT_CMD_ID_SKU_CODE_SET"},
        {0x007E,"TWU_AT_CMD_ID_SKU_CODE_GET"},
        {0x007F,"TWU_AT_CMD_ID_PCB_VER_GET"},
        {0x0085,"TWU_AT_CMD_ID_BATT_FUEL_GAUGE_SOC_GET"},
        {0x0086,"TWU_AT_CMD_ID_BATT_FUEL_GAUGE_CURRENT_GET"},
        {0x0091,"TWU_AT_CMD_ID_EDR_TX_TEST_CH38"},
        {0x0094,"TWU_AT_CMD_ID_EDR_RX_TEST_CH38"},
        {0x0096,"TWU_AT_CMD_ID_EDR_TEST_END"},
        {0x0097,"TWU_AT_CMD_ID_LE_TEST_PHY_1M"},
        {0x0098,"TWU_AT_CMD_ID_LE_TEST_PHY_2M"},
        {0x0099,"TWU_AT_CMD_ID_LE_TEST_GET_PHY"},
        {0x00A0,"TWU_AT_CMD_ID_LE_TEST_PKT_SIZE_37"},
        {0x00A1,"TWU_AT_CMD_ID_LE_TEST_PKT_SIZE_255"},
        {0x00A6,"TWU_AT_CMD_ID_LE_RX_TEST_CH39"},
        {0x00A7,"TWU_AT_CMD_ID_BT_TX_TEST_CH02"},
        {0x00A8,"TWU_AT_CMD_ID_BT_TX_TEST_CH40"},
        {0x00A9,"TWU_AT_CMD_ID_BT_TX_TEST_CH41"},
        {0x00AA,"TWU_AT_CMD_ID_BT_TX_TEST_CH80"},
        {0x00AB,"TWU_AT_CMD_ID_LE_TX_TEST_CH18"},
        {0x00AC,"TWU_AT_CMD_ID_LE_RX_TEST_CH18"},
        {0x00AD,"TWU_AT_CMD_ID_DID_SET"},
        {0x00AE,"TWU_AT_CMD_ID_DID_GET"},
        {0x00AF,"TWU_AT_CMD_ID_TSP_INT_PIN_TEST"},
        {0x00B0,"SPKSTEST"},
        {0x00B1,"SPKSTEST"},
        {0x00B2,"TWU_AT_CMD_ID_AUDIO_ANC_VOLUME_LEVEL_SET"},
        {0x00B3,"TWU_AT_CMD_ID_ACC_ONESHOT"},
        {0x00B4,"TWU_AT_CMD_ID_VPU_OFF"},
        {0x00B5,"TWU_AT_CMD_ID_VPU_ON"},
        {0x00B6,"TWU_AT_CMD_ID_VPU_ONESHOT"},
        {0x00B7,"TWU_AT_CMD_ID_VPU_VIBRATION"},
        {0x00B8,"CODECCHK"},
        {0x00B9,"CODECCHK"},
        {0x00BA,"TWU_AT_CMD_ID_VPU_READ"},
        {0x00BB,"CONNTEST"},
        {0x00BD,"TWU_AT_CMD_ID_AUDIO_CS_TEST_MODE_ON"},
        {0x00BE,"TWU_AT_CMD_ID_AUDIO_CS_TEST_MODE_OFF"},
        {0x00BF,"TWU_AT_CMD_ID_AUDIO_CS_TEST_500HZ_MIC_GAIN"},
        {0x00C0,"TWU_AT_CMD_ID_AUDIO_CS_TEST_1000HZ_MIC_GAIN"},
        {0x00C1,"TWU_AT_CMD_ID_AUDIO_CS_TEST_1500HZ_MIC_GAIN"},
        {0x00C2,"TWU_AT_CMD_ID_BATT_VENDOR_INFO_SET"},
        {0x00C3,"TWU_AT_CMD_ID_BATT_VENDOR_INFO_GET"},
        {0x00C4,"TWU_AT_CMD_ID_TSP_IC_RESET"},
        {0x00C5,"TWU_AT_CMD_ID_HEAD_ALL_INFO"},
        {0x00C6,"TWU_AT_CMD_ID_PROXIMITY_2_ON"},
        {0x00C7,"TWU_AT_CMD_ID_PROXIMITY_2_CHECK"},
        {0x00C8,"TWU_AT_CMD_ID_PROXIMITY_2_ADC_READ"},
        {0x00C9,"TWU_AT_CMD_ID_PROXIMITY_2_CAL"},
        {0x00CA,"TWU_AT_CMD_ID_PROXIMITY_2_OFF"},
        {0x00CB,"TWU_AT_CMD_ID_POWER_OFF_TIMER"},
        {0x00CC,"TWU_AT_CMD_ID_BATT_ADC_GET"},
        {0x00CD,"TWU_AT_CMD_ID_BATT_POGO_STATUS_GET"},
        {0x00CE,"LOOPTEST"},
        {0x00CF,"LOOPTEST"},
        {0x00D1,"TWU_AT_CMD_ID_ACC_VARIANCE"},
        {0x00D2,"TWU_AT_CMD_ID_ACC_READ_GYRO_BIAS"},
        {0x00D3,"TWU_AT_CMD_ID_ACC_CLEAR_GYRO_BIAS"},
        {0x00D5,"TWU_AT_CMD_ID_ACC_ONESHOT_USR"},
        {0x00D6,"TWU_AT_CMD_ID_BT_PRINT_ADDR_HISTORY"},
        {0x00D7,"TWU_AT_CMD_ID_BT_READ_RSSI"},
        {0x00D8,"TWU_AT_CMD_ID_BT_ADDR_PEER_SET"},
        {0x00D9,"TWU_AT_CMD_ID_BT_ADDR_PEER_GET"},
        {0x00DA,"TWU_AT_CMD_ID_BT_RF_PLL_REGISTER_CHECK"},
        {0x00DC,"TWU_AT_CMD_ID_SRAM_TEST_CHECK00"},
        {0x00E0,"TWU_AT_CMD_ID_HALLIC_SH_ON"},
        {0x00E1,"TWU_AT_CMD_ID_HALLIC_SH_READ"},
        {0x00E2,"TWU_AT_CMD_ID_HALLIC_SH_SELFTEST"},
        {0x00E3,"TWU_AT_CMD_ID_HALLIC_SH_OFF"},
        {0x00FF,"TWU_AT_CMD_ID_BT_RF_TEST"},
        {0x0103,"TWU_AT_CMD_ID_PLC_TEST_TSP_PAIRING"},
        {0x0185,"FUELGAIC"},
        {0x0285,"FUELGAIC"},
        {0x1024,"TWU_AT_CMD_ID_PROXIMITY_1_CAL"},
        {0x1025,"TWU_AT_CMD_ID_PROXIMITY_1_ONESHOT"},
        {0x1103,"FCBTTEST_COUPLING_CHECK"},
        {0x1AC0,"TWU_AT_CMD_ID_TSP_FIRST_STAB_SET"},
        {0x1AC1,"TWU_AT_CMD_ID_TSP_FIRST_STAB_GET"},
        {0x7700,"TWU_AT_CMD_ID_ACT_MODE"},
        {0x7711,"TWU_AT_CMD_ID_ACT_CMD"},
        {0x7722,"TWU_AT_CMD_ID_TSP_SIDE_DOUBLE_TAP_SET"},
        {0x7733,"TWU_AT_CMD_ID_TSP_SIDE_DOUBLE_TAP_GET"},
        {0x8888,"PLC_COUPLING_START"},
        {0x88D5,"TWU_AT_CMD_ID_TSP_INDEFFERENCE_SET"},
        {0x88D6,"TWU_AT_CMD_ID_TSP_INDEFFERENCE_GET"},
        {0x88D7,"TWU_AT_CMD_ID_TSP_DEBOUNCE_SET"},
        {0x88D8,"TWU_AT_CMD_ID_TSP_DEBOUNCE_GET"},
        {0x88D9,"TWU_AT_CMD_ID_TSP_THRESHOLD_SET"},
        {0x88DA,"TWU_AT_CMD_ID_TSP_THRESHOLD_GET"},
        {0x88DB,"TWU_AT_CMD_ID_BT_TEST_TIMER_START"},
        {0x88DC,"TWU_AT_CMD_ID_BT_TEST_TIMER_END"},
        {0x88DD,"TWU_AT_CMD_ID_SL_ALLSENSOR_ON"},
        {0x88DE,"TWU_AT_CMD_ID_SL_ALLSENSOR_OFF"},
        {0x980D,"SENSORLOGGING_ON"},
        {0x980E,"SENSORLOGGING_OFF"},
        {0x990A,"TWU_AT_CMD_ID_SL_200Hz_DATA_ON"},
        {0x990B,"TWU_AT_CMD_ID_SL_200Hz_DATA_OFF"},
        {0x990D,"SENSORLOGGING_ON"},
        {0x990E,"SENSORLOGGING_OFF"},
        {0x990F,"SET_HIGH_BATTERY"},
        {0x9910,"TWU_AT_CMD_ID_PLACE_TEST_WEAR"},
        {0x9911,"TWU_AT_CMD_ID_PLACE_TEST_OUTSIDE"},
        {0x9912,"TWU_AT_CMD_ID_PLACE_TEST_INCLOSECASE"},
        {0x9913,"TWU_AT_CMD_ID_PLACE_TEST_INOPENCASE"},
        {0x9999,"SWREBOOT"},
        {0xAC00,"TWU_AT_CMD_ID_AUDIO_ANC_ANC_OFF"},
        {0xAC01,"TWU_AT_CMD_ID_AUDIO_ANC_ANC_ON"},
        {0xAC02,"TWU_AT_CMD_ID_AUDIO_ANC_GET_FB_MIC_SENSITIVITY"},
        {0xAC03,"TWU_AT_CMD_ID_AUDIO_ANC_GET_FF_MIC_SENSITIVITY"},
        {0xAC04,"TWU_AT_CMD_ID_AUDIO_ANC_FB_GAIN_SET"},
        {0xAC05,"TWU_AT_CMD_ID_AUDIO_ANC_FF_GAIN_SET"},
        {0xAC06,"TWU_AT_CMD_ID_AUDIO_ANC_SET_BEST_FB_ADC"},
        {0xAC07,"TWU_AT_CMD_ID_AUDIO_ANC_SET_BEST_FF_ADC"},
        {0xAC08,"TWU_AT_CMD_ID_AUDIO_ANC_GET_BEST_FB_ADC"},
        {0xAC09,"TWU_AT_CMD_ID_AUDIO_ANC_GET_BEST_FF_ADC"},
        {0xAC0A,"TWU_AT_CMD_ID_AUDIO_ANC_FF_MIC_ON"},
        {0xAC0B,"TWU_AT_CMD_ID_AUDIO_ANC_FF_MIC_OFF"},
        {0xAC0C,"TWU_AT_CMD_ID_AUDIO_ANC_FB_MIC_ON"},
        {0xAC0D,"TWU_AT_CMD_ID_AUDIO_ANC_FB_MIC_OFF"},
        {0xAC0E,"TWU_AT_CMD_ID_AUDIO_ANC_SET_SWEEPSOUND_RESULT"},
        {0xAC0F,"TWU_AT_CMD_ID_AUDIO_ANC_GET_SWEEPSOUND_RESULT"},
        {0xAC10,"TWU_AT_CMD_ID_AUDIO_ANC_SWEEPSOUND_FOR_SPK_THD"},
        {0xAC11,"TWU_AT_CMD_ID_AUDIO_ANC_OED_LOOPBACK_TEST"},
        {0xAC12,"TWU_AT_CMD_ID_AUDIO_ANC_SWEEPSOUND_COMPENSATION"},
        {0xAC13,"TWU_AT_CMD_ID_AUDIO_ANC_OED_LOOPBACK_TEST_ON_JIG"},
        {0xAC14,"TWU_AT_CMD_ID_AUDIO_SET_EQ_MDOE"},
        {0xAC1E,"TWU_AT_CMD_ID_AUDIO_ANC_SET_GOLDEN_SAMPLE_DATA"},
        {0xAC1F,"TWU_AT_CMD_ID_AUDIO_ANC_ANC_ON_WITH_USER_CONDITION"},
        {0xAC20,"TWU_AT_CMD_ID_AUDIO_ANC_ENABLE_TALKTHRU"},
        {0xAC21,"TWU_AT_CMD_ID_AUDIO_ANC_GET_GOLDEN_SAMPLE_DATA"},
        {0xAC22,"TWU_AT_CMD_ID_AUDIO_ANC_DISABLE_TALKTHRU"},
        {0xAC23,"TWU_AT_CMD_ID_AUDIO_ANC_ANC_FB_ONLY_MODE"},
        {0xAC24,"TWU_AT_CMD_ID_AUDIO_ANC_PSAP_LEVEL1"},
        {0xAC25,"TWU_AT_CMD_ID_AUDIO_ANC_PSAP_LEVEL2"},
        {0xAC26,"TWU_AT_CMD_ID_AUDIO_ANC_PSAP_LEVEL3"},
        {0xAC27,"TWU_AT_CMD_ID_AUDIO_ANC_PSAP_LEVEL4"},
        {0xAC30,"TWU_AT_CMD_ID_AUDIO_ANC_ANC_ONESHOT"},
        {0xAC31,"TWU_AT_CMD_ID_AUDIO_ANC_AMBIENT_ONESHOT"},
        {0xAC50,"TWU_AT_CMD_ID_AUDIO_ANC_LEAK_DETECT"},
        {0xAD00,"TWU_AT_CMD_ID_AUDIO_MIC_ONESHOT"},
        {0xAD01,"TWU_AT_CMD_ID_AUDIO_MIC_VP_ADC_HALL_OPEN"},
        {0xAD02,"TWU_AT_CMD_ID_AUDIO_MIC_FF_ADC_HALL_OPEN"},
        {0xAD03,"TWU_AT_CMD_ID_AUDIO_MIC_FB_ADC_HALL_OPEN"},
        {0xAD04,"TWU_AT_CMD_ID_AUDIO_MIC_VP_ADC_HALL_CLOSE"},
        {0xAD05,"TWU_AT_CMD_ID_AUDIO_MIC_FF_ADC_HALL_CLOSE"},
        {0xAD07,"TWU_AT_CMD_ID_AUDIO_MIC_VP_MUTE_ADC"},
        {0xAD08,"TWU_AT_CMD_ID_AUDIO_MIC_FF_MUTE_ADC"},
        {0xAD11,"TWU_AT_CMD_ID_AUDIO_MIC_VP_LOOPBACK"},
        {0xAD12,"TWU_AT_CMD_ID_AUDIO_MIC_FF_LOOPBACK"},
        {0xAD13,"TWU_AT_CMD_ID_AUDIO_MIC_FB_LOOPBACK"},
        {0xADFF,"TWU_AT_CMD_ID_AUDIO_MIC_END"},
        {0xBB01,"TWU_AT_CMD_ID_BATT_SOC_CYCLE_RESET"},
        {0xBB02,"TWU_AT_CMD_ID_BATT_SOC_CYCLE_GET"},
        {0xBB04,"TWU_AT_CMD_ID_BATT_SOC_CYCLE_SET"},
        {0xBBF0,"TWU_AT_CMD_ID_FOTA_PCKT_NUM"},
        {0xC000,"TWU_AT_CMD_ID_SL_DATA_ON"},
        {0xD0FF,"TWU_AT_CMD_ID_SL_DATA_OFF"},
        {0xE001,"GETFULLTESTNV"},
        {0xE002,"SETTESTNV:99,P"},
        {0xE003,"GETFULLHISTNV"},
        {0xE004,"LOGERASE"},
        {0xF000, "TWU_AT_CMD_ID_GET_APPROVAL_HW_VER"},
        {0xF001, "TWU_AT_CMD_ID_GET_APPROVAL_SW_VER"},
        {0xF010, "TWU_AT_CMD_UNSET_USER_UART_ENABLE"},
        {0xF011, "TWU_AT_CMD_SET_USER_UART_ENABLE"},
        {0xF012, "TWU_AT_CMD_GET_USER_UART_ENABLE"},
    };
}