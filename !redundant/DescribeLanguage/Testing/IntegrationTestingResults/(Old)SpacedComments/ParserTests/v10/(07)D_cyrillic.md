========================================
Source Code (between the arrows)
========================================

🡆платове <ФЛГмссД5> ->

	вълнени платове <ПеП0ТхЗй>,
	памучни платове <ПТъЗАфЪа>,
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
│   │   └── T(TAG|'<ФЛГмссД5> ')
│   ├── producer
│   │   ├── T(HYPHEN|'-')
│   │   └── T(PRODUCTION_ARROW|'>\r\n\r\n\t')
│   ├── item_or_expression_list
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'вълнени платове ')
│   │   │   │   └── T(TAG|'<ПеП0ТхЗй>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'памучни платове ')
│   │   │   │   └── T(TAG|'<ПТъЗАфЪа>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   ├── item_or_expression_part
│   │   │   ├── item
│   │   │   │   ├── text_chunk
│   │   │   │   │   └── T(DATA|'копринени платове ')
│   │   │   │   └── T(TAG|'<5Суак3ИЙ>')
│   │   │   └── T(SEPARATOR|',\r\n\t')
│   │   └── item
│   │       ├── text_chunk
│   │       │   └── T(DATA|'синтетични платове ')
│   │       └── T(TAG|'<ЛКтрт5КН>')
│   └── T(TERMINATOR|';')
└── T(EOF|'<EOF>')