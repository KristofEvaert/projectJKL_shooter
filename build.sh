echo exporting
# Build game and export it to HTML
cd Game
# requires to have godot mono installed
godot --export "HTML5"
cd ..
# copies the exported game files
cp -r Game/build build/
# copies the main html file
cp projectJKL2dshooter.html build/index.html

