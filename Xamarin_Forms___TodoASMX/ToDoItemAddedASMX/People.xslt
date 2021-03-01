<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

	<xsl:template match="/ | node()">
		<xsl:copy>
			<table class="table table-bordered">
				<thead>
					<tr>
						<th>ID</th>
						<th>Name</th>
						<th>Phone</th>
						<th>Department</th>
						<th>Address</th>
					</tr>
				</thead>
				<tbody>
					<xsl:for-each select="People/Person">
						<tr>
							<td>
								<xsl:value-of select ="@Id"/>
							</td>
							<td>
								<xsl:value-of select="Name"/>
							</td>
							<td>
								<xsl:value-of select ="Phone"/>
							</td>
							<td>
								<xsl:value-of select ="Department"/>
							</td>
							<td>
								<xsl:value-of select="concat(Address/Street,' ',Address/City,' ', Address/State,' ',Address/ZIP,' ', Address/Country)" />
							</td>
						</tr>
					</xsl:for-each>
				</tbody>
			</table>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>
