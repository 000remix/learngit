<?xml version="1.0" encoding="utf-8" ?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/ArrayOfOrder">
    <html>
      <head>
        <title>DotNet Orders</title>
      </head>
      <body>
        <ul>
          <xsl:for-each select="Order">
            <li>
              <xsl:value-of select="ID" />
            </li>
            <li>
              <xsl:value-of select="Customer" />
            </li>
            <li>
              <xsl:value-of select="Commodity" />
            </li>
          </xsl:for-each>
        </ul>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>