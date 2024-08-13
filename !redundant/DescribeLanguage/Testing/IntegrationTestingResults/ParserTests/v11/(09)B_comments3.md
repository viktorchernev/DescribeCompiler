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
│   │   ├── text_chunk
│   │   │   └── T(LEFT_ARROW|'<')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'QuvD4gqX')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>        // dude;\r\n\r\n    ')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'wool fabrics ')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(LEFT_ARROW|'<')
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'VBsu8OpW')
│   │   │   │   └── text_chunk
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|', /* comment <*/\r\n')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'cotton fabrics ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_ARROW|'<')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'0RdNAvNs')
│   │       ├── text_chunk
│   │       │   └── T(RIGHT_ARROW|'> ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_CURL|'{')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'dec')
│   │       ├── text_chunk
│   │       │   └── T(RIGHT_CURL|'} ')
│   │       ├── text_chunk
│   │       │   └── T(LEFT_SQUARE|'[')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'https')
│   │       ├── text_chunk
│   │       │   └── T(PROTO_SLASHES|'://')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'www.notube.com')
│   │       ├── text_chunk
│   │       │   └── T(FORWARD_SLASH|'/')
│   │       ├── text_chunk
│   │       │   └── T(DATA|'watch?v=hTui12lKus')
│   │       └── text_chunk
│   │           └── T(RIGHT_SQUARE|']')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')