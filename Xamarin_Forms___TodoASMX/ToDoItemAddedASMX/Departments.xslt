﻿<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

	<xsl:template match="/ | node()">
		<xsl:copy>
			<table class="table table-bordered">
				<thead>
					<tr>
						<th>Id</th>
						<th>Name</th>
					</tr>
				</thead>
				<tbody>
					<xsl:for-each select="Departments/Department">
						<tr>
							<td>
								<xsl:value-of select="@ID"/>
							</td>
							<td>
								<xsl:value-of select="Name"/>
							</td>
						</tr>
					</xsl:for-each>
				</tbody>
			</table>
		</xsl:copy>
	</xsl:template>
</xsl:stylesheet>