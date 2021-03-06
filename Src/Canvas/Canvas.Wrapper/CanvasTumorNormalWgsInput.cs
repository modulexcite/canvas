﻿using Illumina.SecondaryAnalysis.VariantCalling;
using Isas.Framework.DataTypes;
using Isas.SequencingFiles;

namespace Canvas.Wrapper
{
    public class CanvasTumorNormalWgsInput : ICanvasCheckpointInput
    {
        public Bam TumorBam { get; }
        public Bam NormalBam { get; }
        public Vcf NormalVcf { get; } // set to the starling VCF path 
        public Vcf SomaticVcf { get; } // set to the strelka VCF path
        public GenomeMetadata GenomeMetadata { get; }
        public SexPloidyInfo SexPloidy { get; }

        public CanvasTumorNormalWgsInput(Bam tumorBam, Bam normalBam, Vcf normalVcf, Vcf somaticVcf, GenomeMetadata genomeMetadata, SexPloidyInfo sexPloidy)
        {
            TumorBam = tumorBam;
            NormalBam = normalBam;
            NormalVcf = normalVcf;
            SomaticVcf = somaticVcf;
            GenomeMetadata = genomeMetadata;
            SexPloidy = sexPloidy;
        }
    }
}