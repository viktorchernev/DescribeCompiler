The describe compiler is templateable - you can provide your own output templates (aka stencils) that contain "sockets" - the text in curly brackets, and the data from the parsed lists will replace those "socket" placeholder text. You can put any text in those output templates.

You could also implement your own translator class if needed, but this is another topic. Below is template data for the default translator:  
  
• "Root" must have the socket `{ITEMS}`  
• "Production" must have the sockets `{TITLE}` and `{ITEMS}`  
• "Page" must have the socket `{DATA}`  
• "Item" must have the socket `{TEXT}`  
• "ItemColored" must have the sockets `{TEXT}` and `{COLOR}`  
• "ItemComment" must have the sockets `{TEXT}`  
• "ItemEmpty" need not have socket(s)  
• "Link" must have the sockets `{TEXT}` and `{HTTPS}`  