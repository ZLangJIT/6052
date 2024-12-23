# CS_ARCH_MIPS, CS_MODE_MIPS32+CS_MODE_MICRO, None

0xa0,0x30,0x7b,0x00 == addiu $5, $zero, 123        # encoding: [0xa0,0x30,0x7b,0x00]
0xc0,0x30,0xd7,0xf6 == addiu $6, $zero, -2345      # encoding: [0xc0,0x30,0xd7,0xf6]
0xa7,0x41,0x01,0x00 == lui   $7, 1                 # encoding: [0xa7,0x41,0x01,0x00]
0xe7,0x50,0x02,0x00 == ori   $7, $7, 2             # encoding: [0xe7,0x50,0x02,0x00]
0x80,0x30,0x14,0x00 == addiu $4, $zero, 20         # encoding: [0x80,0x30,0x14,0x00]
0xa7,0x41,0x01,0x00 == lui   $7, 1                 # encoding: [0xa7,0x41,0x01,0x00]
0xe7,0x50,0x02,0x00 == ori   $7, $7, 2             # encoding: [0xe7,0x50,0x02,0x00]
0x85,0x30,0x14,0x00 == addiu $4, $5, 20            # encoding: [0x85,0x30,0x14,0x00]
0xa7,0x41,0x01,0x00 == lui   $7, 1                 # encoding: [0xa7,0x41,0x01,0x00]
0xe7,0x50,0x02,0x00 == ori   $7, $7, 2             # encoding: [0xe7,0x50,0x02,0x00]
0x07,0x01,0x50,0x39 == addu  $7, $7, $8            # encoding: [0x07,0x01,0x50,0x39]
0xaa == lui   $10, %hi(symbol)      # encoding: [0xaa'A',0x41'A',0x00,0x00]
0x8a,0x00,0x50,0x51 == addu  $10, $10, $4          # encoding: [0x8a,0x00,0x50,0x51]
0x4a == lw    $10, %lo(symbol)($10) # encoding: [0x4a'A',0xfd'A',0x00,0x00]
0xa1 == lui   $1, %hi(symbol)       # encoding: [0xa1'A',0x41'A',0x00,0x00]
0x21,0x01,0x50,0x09 == addu  $1, $1, $9            # encoding: [0x21,0x01,0x50,0x09]
0x41 == sw    $10, %lo(symbol)($1)  # encoding: [0x41'A',0xf9'A',0x00,0x00]
0xaa,0x41,0x0a,0x00 == lui   $10, 10               # encoding: [0xaa,0x41,0x0a,0x00]
0x8a,0x00,0x50,0x51 == addu  $10, $10, $4          # encoding: [0x8a,0x00,0x50,0x51]
0x4a,0xfd,0x7b,0x00 == lw    $10, 123($10)         # encoding: [0x4a,0xfd,0x7b,0x00]
0xa1,0x41,0x02,0x00 == lui   $1, 2                 # encoding: [0xa1,0x41,0x02,0x00]
0x21,0x01,0x50,0x09 == addu  $1, $1, $9            # encoding: [0x21,0x01,0x50,0x09]
0x41,0xf9,0x40,0xe2 == sw    $10, -7616($1)        # encoding: [0x41,0xf9,0x40,0xe2]
