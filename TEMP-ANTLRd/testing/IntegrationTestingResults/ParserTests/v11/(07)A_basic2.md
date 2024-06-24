========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics <i1NLckN6>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   └── text_chunk
│   │       └── T(DATA|'fabrics ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> \r\n\t\r\n\t')
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'synthetic fabrics ')
│   │   ├── text_chunk
│   │   │   └── T(LEFT_ARROW|'<')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'i1NLckN6')
│   │   └── text_chunk
│   │       └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')