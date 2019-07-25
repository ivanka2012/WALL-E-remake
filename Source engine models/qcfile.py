template = """$modelname "{}"
$scale 2
$body {} "{}"
$staticprop
$surfaceprop "metal"
$cdmaterials "models\\"
$sequence idle "{}.smd"
$keyvalues
{{
	prop_data
	{{
		base			Metal.Small
	}}
}}
"""
import glob, os
for file in glob.glob("*.smd"):
    f = open(os.path.splitext(file)[0]+".qc","w+")
    s = template.format(os.path.splitext(file)[0], os.path.splitext(file)[0], os.path.splitext(file)[0], os.path.splitext(file)[0])
    f.write(s)
    f.close()