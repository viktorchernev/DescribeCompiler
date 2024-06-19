========================================
Source Code (between the arrows)
========================================

🡆fabrics <QuvD4gqX> ->        // dude;

    wool fabrics <VBsu8OpW>, /* comment <*/
/* -> {decorator} Comments, man [https://www.notube.com/watch?v=hTui12lKus] */     cotton fabrics <0RdNAvNs> {dec} [https://www.notube.com/watch?v=hTui12lKus];🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   └── T(TAG|'<QuvD4gqX> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>        // dude;\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   └── T(TAG|'<VBsu8OpW>')
│   │   │   └── T(SEPARATOR|', /* comment <*/\r\n')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'cotton fabrics ')
│   │       ├── T(TAG|'<0RdNAvNs> ')
│   │       ├── T(DECORATOR|'{dec} ')
│   │       └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')