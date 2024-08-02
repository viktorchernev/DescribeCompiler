========================================
Source Code (between the arrows)
========================================

🡆fabrics [https://www.notube.com/watch?v=hTui12lKus]-> 
	
	synthetic fabrics https://some-link/
	<i1NLckN6> 
	[https://www.notube.com/watch?v=hTui12lKus]
	{
		info | more info here
	}
	;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'fabrics ')
│   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> \r\n\t\r\n\t')
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'synthetic fabrics https:')
│   │   ├── text_chunk
│   │   │   └── T(FORWARD_SLASHES|'//')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'some')
│   │   ├── text_chunk
│   │   │   └── T(HYPHEN|'-')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'link')
│   │   ├── text_chunk
│   │   │   └── T(FORWARD_SLASH|'/\r\n\t')
│   │   ├── T(TAG|'<i1NLckN6> \r\n\t')
│   │   ├── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]\r\n\t')
│   │   └── T(DECORATOR|'{\r\n\t\tinfo | more info here\r\n\t}\r\n\t')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')