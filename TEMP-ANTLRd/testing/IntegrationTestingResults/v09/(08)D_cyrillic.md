========================================
Source Code (between the arrows)
========================================

🡆платове <ФЛГмссД> ->

	вълнени платове <ПеП0ТхЗй>[https://www.домейн.com/watch?v=hTui12lKus],
	памучни платове <ПТъЗАфЪа>[https://www.notube.com/watch?v=hTui12lKus],
	копринени платове <5Суак3ИЙ>,
	синтетични платове <ЛКтрт5КН>;🡄

========================================
Parse Tree
========================================

scripture
├── expression
│   ├── item
│   │   ├── text_chunk
│   │   │   └── T(DATA|'платове ')
│   │   └── tag
│   │       ├── T(LEFT_ARROW|'<')
│   │       ├── T(DATA|'ФЛГмссД')
│   │       └── T(RIGHT_ARROW|'> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(RIGHT_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'вълнени платове ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'ПеП0ТхЗй')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.домейн.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'памучни платове ')
│   │   │   │   ├── tag
│   │   │   │   │   ├── T(LEFT_ARROW|'<')
│   │   │   │   │   ├── T(DATA|'ПТъЗАфЪа')
│   │   │   │   │   └── T(RIGHT_ARROW|'>')
│   │   │   │   └── T(LINK|'[https://www.notube.com/watch?v=hTui12lKus]')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'копринени платове ')
│   │   │   │   └── tag
│   │   │   │       ├── T(LEFT_ARROW|'<')
│   │   │   │       ├── T(DATA|'5Суак3ИЙ')
│   │   │   │       └── T(RIGHT_ARROW|'>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'синтетични платове ')
│   │       └── tag
│   │           ├── T(LEFT_ARROW|'<')
│   │           ├── T(DATA|'ЛКтрт5КН')
│   │           └── T(RIGHT_ARROW|'>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')