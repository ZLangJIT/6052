# CS_ARCH_AARCH64, 0, None

0x1f,0x40,0x00,0xd5 == cfinv
0x2d,0x08,0x00,0x3a == setf8 w1
0xed,0x0b,0x00,0x3a == setf8 wzr
0x2d,0x48,0x00,0x3a == setf16 w1
0xed,0x4b,0x00,0x3a == setf16 wzr
0x2f,0x84,0x1f,0xba == rmif x1, #63, #15
0xef,0x87,0x1f,0xba == rmif xzr, #63, #15