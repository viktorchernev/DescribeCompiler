========================================
Source Code (between the arrows)
========================================

🡆fabrics ->        //dude;

    wool fabrics, /* comment <*/
/* ->Comments, man */    cotton fabrics;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── item_or_expression_list
│   │   ├── item
│   │   │   ├── text_chunk
│   │   │   │   └── T(DATA|'        ')
│   │   │   └── text_chunk
│   │   │       └── T(DATA|'\n    wool fabrics')
│   │   ├── T(SEPARATOR|',')
│   │   └── item_or_expression
│   │       └── item
│   │           ├── text_chunk
│   │           │   └── T(DATA|' ')
│   │           ├── text_chunk
│   │           │   └── T(NEWLINE|'\n')
│   │           └── text_chunk
│   │               └── T(DATA|'    cotton fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')