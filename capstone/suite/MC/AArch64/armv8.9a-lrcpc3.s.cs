# CS_ARCH_AARCH64, 0, None

0x18,0x0a,0x00,0x99 == stilp   w24, w0, [x16, #-8]!
0x18,0x0a,0x00,0x99 == stilp   w24, w0, [x16, #-8]!
0x39,0x0a,0x01,0xd9 == stilp   x25, x1, [x17, #-16]!
0x39,0x0a,0x01,0xd9 == stilp   x25, x1, [x17, #-16]!
0x5a,0x1a,0x02,0x99 == stilp   w26, w2, [x18]
0x5a,0x1a,0x02,0x99 == stilp   w26, w2, [x18]
0xfb,0x1b,0x03,0xd9 == stilp   x27, x3, [sp]
0xfb,0x1b,0x03,0xd9 == stilp   x27, x3, [sp]
0x9c,0x0a,0x44,0x99 == ldiapp  w28, w4, [x20], #8
0x9c,0x0a,0x44,0x99 == ldiapp  w28, w4, [x20], #8
0x9c,0x0a,0x44,0x99 == ldiapp  w28, w4, [x20], #8
0x9c,0x0a,0x44,0x99 == ldiapp  w28, w4, [x20], #8
0xbd,0x0a,0x45,0xd9 == ldiapp  x29, x5, [x21], #16
0xbd,0x0a,0x45,0xd9 == ldiapp  x29, x5, [x21], #16
0xfe,0x1b,0x46,0x99 == ldiapp  w30, w6, [sp]
0xfe,0x1b,0x46,0x99 == ldiapp  w30, w6, [sp]
0xff,0x1a,0x47,0xd9 == ldiapp  xzr, x7, [x23]
0xff,0x1a,0x47,0xd9 == ldiapp  xzr, x7, [x23]
0xe3,0x09,0x80,0x99 == stlr w3, [x15, #-4]!
0xe3,0x09,0x80,0x99 == stlr w3, [x15, #-4]!
0xe3,0x09,0x80,0xd9 == stlr x3, [x15, #-8]!
0xe3,0x0b,0x80,0xd9 == stlr x3, [sp, #-8]!
0xe3,0x0b,0xc0,0x99 == ldapr w3, [sp], #4
0xe3,0x09,0xc0,0x99 == ldapr w3, [x15], #4
0xe3,0x09,0xc0,0xd9 == ldapr x3, [x15], #8
0xe3,0x09,0xc0,0xd9 == ldapr x3, [x15], #8
0xe3,0xf9,0x1f,0x1d == stlur b3, [x15, #-1]
0xe3,0x29,0x00,0x5d == stlur h3, [x15, #2]
0xe3,0xd9,0x1f,0x9d == stlur s3, [x15, #-3]
0xe3,0x4b,0x00,0xdd == stlur d3, [sp, #4]
0xe3,0xb9,0x9f,0x1d == stlur q3, [x15, #-5]
0xe3,0x69,0x40,0x1d == ldapur b3, [x15, #6]
0xe3,0x99,0x5f,0x5d == ldapur h3, [x15, #-7]
0xe3,0x89,0x40,0x9d == ldapur s3, [x15, #8]
0xe3,0x79,0x5f,0xdd == ldapur d3, [x15, #-9]
0xe3,0xab,0xc0,0x1d == ldapur q3, [sp, #10]
0xe3,0x85,0x01,0x0d == stl1  { v3.d }[0], [x15]
0xe3,0x85,0x01,0x0d == stl1  { v3.d }[0], [x15]
0xe3,0x87,0x01,0x4d == stl1  { v3.d }[1], [sp]
0xe3,0x87,0x01,0x4d == stl1  { v3.d }[1], [sp]
0xe3,0x87,0x41,0x0d == ldap1 { v3.d }[0], [sp]
0xe3,0x87,0x41,0x0d == ldap1 { v3.d }[0], [sp]
0xe3,0x85,0x41,0x4d == ldap1 { v3.d }[1], [x15]
0xe3,0x85,0x41,0x4d == ldap1 { v3.d }[1], [x15]
