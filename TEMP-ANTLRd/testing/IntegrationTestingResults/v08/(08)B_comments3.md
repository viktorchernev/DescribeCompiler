========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        //dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* ->Comments, man [https://www.notube.com/watch?v=hTui12lKus] */     cotton fabrics <0RdNAvNs> [https://www.notube.com/watch?v=hTui12lKus];🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'QuvD4gqX')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>        ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'\r\n    wool fabrics ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'VBsu8OpW')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|', ')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(NEWLINE|'\r\n')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'     cotton fabrics ')
│   │       ├── tag
│   │       │   ├── T(LEFT_ARROW|'<')
│   │       │   ├── T(DATA|'0RdNAvNs')
│   │       │   └── T(RIGHT_ARROW|'> ')
│   │       └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')