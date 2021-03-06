namespace NSimulator.Library {
    /// <summary>
    /// </summary>
    public sealed class IPPacket {
        // todo
    }

    /*
     * ��������� IP-������:
     *  0 1 2 3 4 5 6 7 0 1 2 3 4 5 6 7 0 1 2 3 4 5 6 7 0 1 2 3 4 5 6 7
     * +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
     * |Version|  IHL  |      QoS      |         Packet Length         |
     * +-------+-------+---------------+-----+-------------------------+
     * |              ID               |Flags|     Fragment offset     |
     * +---------------+---------------+-----+-------------------------+
     * |      TTL      |   Protocol    |              CRC              |
     * +---------------+---------------+-------------------------------+
     * |                           Source IP                           |
     * +---------------------------------------------------------------+
     * |                        Destination IP                         |
     * +---------------------------------------------------------------+
     * |                      Parameters [optional]                    |
     * +---------------------------------------------------------------+
     * |                             Data                              |
     * +-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+
     * 
     * IHL : ����� � dword, min = 5
     * Id  : ������� ������������, ������������� ��� ����������� ����������
     *       ������������������ ���������� ��� ������ ����������.
     *       ����������������� ����� => ���������� Id
     * Flags : [ 0 | DF | MF ]
     * CRC = ~ ( 16-bit ^ 16-bit ^ ... )
     * Protocol : ICMP(1), IPv4(4), TCP(6), UDP(17), IPv6(41), ... [see IANA]
     */
}
