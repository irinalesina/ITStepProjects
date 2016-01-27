<?xml version="1.0" encoding="utf-8"?>

<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:variable name="pupil_gr" select="document(pupil_group1.xml)"/>
<xsl:template match="/">
  <html>
  <body>
    
    <h2 style="color: #72B252"><xsl:value-of select="//group_name"/></h2>
    
    <table>
      
      <tr bgcolor="#A3DAFF">
        <td>Pupil ID</td>
        <td>Pupil name</td>
      </tr>
      
      <xsl:for-each select="PupilsGroup/pupils/Value/Pupil">
      <tr bgcolor="#EAF5FF">
        <td>
          <xsl:value-of select="PupilId"/>
        </td>
        <td><xsl:value-of select="name"/></td>
      </tr>

      </xsl:for-each>
      
    </table>
    
  </body>
  </html>
</xsl:template>

</xsl:stylesheet>