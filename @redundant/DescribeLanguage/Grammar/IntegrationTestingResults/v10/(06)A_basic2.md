========================================
Source Code (between the arrows)
========================================

🡆fabrics -> 
	
	synthetic fabrics;🡄

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
│   │   └── text_chunk
│   │       └── T(DATA|'synthetic fabrics')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')