# CS_ARCH_MIPS, CS_MODE_MIPS32+CS_MODE_BIG_ENDIAN, None

0x01,0x2a,0x40,0x05 == lsa        $8, $9, $10, 1              # encoding: [0x01,0x2a,0x40,0x05]
0x01,0x2a,0x40,0x45 == lsa        $8, $9, $10, 2              # encoding: [0x01,0x2a,0x40,0x45]
0x01,0x2a,0x40,0x85 == lsa        $8, $9, $10, 3              # encoding: [0x01,0x2a,0x40,0x85]
0x01,0x2a,0x40,0xc5 == lsa        $8, $9, $10, 4              # encoding: [0x01,0x2a,0x40,0xc5]
