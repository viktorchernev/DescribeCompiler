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
│   │   ├── text_chunk
│   │   │   └── T(LEFT_SQUARE|'[')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'https')
│   │   ├── text_chunk
│   │   │   └── T(PROTO_SLASHES|'://')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'www.notube.com')
│   │   ├── text_chunk
│   │   │   └── T(FORWARD_SLASH|'/')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'watch?v=hTui12lKus')
│   │   └── text_chunk
│   │       └── T(RIGHT_SQUARE|']')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'> \r\n\t\r\n\t')
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'synthetic fabrics https')
│   │   ├── text_chunk
│   │   │   └── T(PROTO_SLASHES|'://')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'some')
│   │   ├── text_chunk
│   │   │   └── T(HYPHEN|'-')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'link')
│   │   ├── text_chunk
│   │   │   └── T(FORWARD_SLASH|'/\r\n\t')
│   │   ├── text_chunk
│   │   │   └── T(LEFT_ARROW|'<')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'i1NLckN6')
│   │   ├── text_chunk
│   │   │   └── T(PRODUCTION_ARROW|'> \r\n\t')
│   │   ├── text_chunk
│   │   │   └── T(LEFT_SQUARE|'[')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'https')
│   │   ├── text_chunk
│   │   │   └── T(PROTO_SLASHES|'://')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'www.notube.com')
│   │   ├── text_chunk
│   │   │   └── T(FORWARD_SLASH|'/')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'watch?v=hTui12lKus')
│   │   ├── text_chunk
│   │   │   └── T(RIGHT_SQUARE|']\r\n\t')
│   │   ├── text_chunk
│   │   │   └── T(LEFT_CURL|'{\r\n\t\t')
│   │   ├── text_chunk
│   │   │   └── T(DATA|'info | more info here\r\n\t')
│   │   └── text_chunk
│   │       └── T(RIGHT_CURL|'}\r\n\t')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')